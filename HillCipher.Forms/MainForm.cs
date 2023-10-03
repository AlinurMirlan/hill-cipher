using HillCipher.Library;
using ScottPlot;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace HillCipher.Forms;

public partial class MainForm : Form
{
    private string _alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ\n.,()?!0123456789«»\"'— +-[]{}";
    private Dictionary<char, int> _lookupTable;
    private const string _keyColumnPrefix = "k";
    private int _keyDimension = 2;
    private readonly ICipher<double[,]> _hillCipher;

    public MainForm()
    {
        InitializeComponent();
        _lookupTable = GetLookupTable(_alphabet);
        _hillCipher = new HillCipher.Library.HillCipher(_alphabet.ToCharArray());
        textBoxAlphabet.Text = _alphabet;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadFrequencyPlotView();
        LoadFrequencyGridView();
        LoadKeySizeGridView();
    }

    private void TextBoxAlphabet_Leave(object sender, EventArgs e)
    {
        string alphabet = RemoveDublicates(textBoxAlphabet.Text);
        if (alphabet.Length <= 0)
        {
            ShowWarningBox("Alphabet must not be empty.");
            DisableCipherButtons();
            return;
        }

        try
        {
            _hillCipher.Alphabet = alphabet.ToCharArray();
        }
        catch (ArgumentException exp)
        {
            ShowWarningBox(exp.Message);
            DisableCipherButtons();
        }

        EnableCipherButtons();
        _alphabet = alphabet;
        _lookupTable = GetLookupTable(alphabet);
    }

    private void ButtonCipher_Click(object sender, EventArgs e) => Cipher(true);

    private void ButtonDecipher_Click(object sender, EventArgs e)
    {
        Cipher(false);
    }

    private void ButtonClearKey_Click(object sender, EventArgs e)
    {
        textBoxKey.Text = string.Empty;
        textBoxKey.Focus();

        object?[] values = Enumerable.Range(1, keyGridView.Columns.Count).Select(_ => (object?)null).ToArray();
        for (int i = 0; i < keyGridView.Rows.Count; i++)
        {
            keyGridView.Rows[i].SetValues(values);
        }
    }

    private void ButtonGenerateKey_Click(object sender, EventArgs e)
    {
        double[,] key = RandomKey(_hillCipher, out string textKey);
        textBoxKey.Text = textKey;
        SetGridKey(key);
    }

    private void ButtonExtractKey_Click(object sender, EventArgs e)
    {
        string originalExcerpt = textBoxOriginalExcerpt.Text;
        string cipheredExcerpt = textBoxCipheredExcerpt.Text;
        if (originalExcerpt.Length <= 0 || cipheredExcerpt.Length <= 0)
            return;

        HillCipherCracker hillCracker = new(_alphabet.ToCharArray());
        double[,] key;
        try
        {
            key = hillCracker.ExtractKey(originalExcerpt, cipheredExcerpt);
        }
        catch (ArgumentException exp)
        {
            ShowWarningBox(exp.Message);
            return;
        }

        SetGridKey(key);
        textBoxKey.Text = AsTextKey(key);
    }

    private void ButtonOpenText_Click(object sender, EventArgs e)
    {
        if (openTextFileDialog.ShowDialog() == DialogResult.OK)
        {
            string selectedFile = openTextFileDialog.FileName;
            try
            {
                string fileContent = File.ReadAllText(selectedFile);
                textBoxTextToProcess.Text = fileContent;
            }
            catch (IOException ex)
            {
                ShowErrorBox($"An error occurred while reading the file: {ex.Message}");
            }
        }
    }

    private void ButtonSaveText_Click(object sender, EventArgs e)
    {
        if (saveTextFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filePath = saveTextFileDialog.FileName;
            string textToSave = textBoxProcessedOutput.Text;

            try
            {
                File.WriteAllText(filePath, textToSave);
                ShowSuccessBox("Text saved to file successfully!");
            }
            catch (IOException ex)
            {
                ShowErrorBox($"An error occurred while saving the file: {ex.Message}");
            }
        }
    }

    private void KeySizeUpDown_ValueChanged(object sender, EventArgs e)
    {
        _keyDimension = (int)keySizeUpDown.Value;
        UpdateKeySizeGridView();
    }

    private void SetGridKey(double[,] key)
    {
        for (int i = 0; i < keyGridView.RowCount; i++)
        {
            for (int j = 0; j < keyGridView.ColumnCount; j++)
                keyGridView[j, i].Value = key[i, j];
        }
    }

    private void LoadKeySizeGridView()
    {
        keyGridView.Columns.Add($"{_keyColumnPrefix}0", string.Empty);
        keyGridView.Columns.Add($"{_keyColumnPrefix}1", string.Empty);
        keyGridView.Rows.Add(null, null);
        keyGridView.Rows.Add(null, null);
    }

    private void UpdateKeySizeGridView()
    {
        if (keyGridView.Columns.Count < _keyDimension)
        {
            keyGridView.Columns.Add($"{_keyColumnPrefix}{_keyDimension}", string.Empty);
            object?[] values = Enumerable.Range(1, _keyDimension).Select(_ => (object?)null).ToArray();
            keyGridView.Rows.Add(values);
        }
        else
        {
            keyGridView.Columns.RemoveAt(keyGridView.Columns.Count - 1);
            keyGridView.Rows.RemoveAt(keyGridView.Rows.Count - 1);
        }
    }

    private void LoadFrequencyPlotView()
    {
        ScottPlot.Plot plot = frequencyPlot.Plot;
        plot.Title("Frequency Plot");
        plot.XLabel("Alphabet");
        plot.YLabel("Frequency");
        PlotFrequency(
            letterFrequencies: Constants.RussianLetterFrequencies
                .OrderByDescending(letter => letter.Frequency),
            label: "Alphabet");
    }

    private void PlotFrequency(IEnumerable<LetterFrequency> letterFrequencies, string label)
    {
        ScottPlot.Plot plot = frequencyPlot.Plot;
        plot.AddScatter(
            xs: Enumerable.Range(1, letterFrequencies.Count()).Select(n => (double)n).ToArray(),
            ys: letterFrequencies.Select(letter => letter.Frequency).ToArray(),
            label: label);
        plot.Legend();
        frequencyPlot.Refresh();
    }

    private void LoadFrequencyGridView()
    {
        foreach (LetterFrequency letter in Constants.RussianLetterFrequencies)
            letterFrequencyGrid.Rows.Add(letter.Letter, letter.Frequency);

        letterFrequencyGrid.Sort(letterFrequencyGrid.Columns[1], ListSortDirection.Descending);
    }

    private void PlotLetterFrequencies()
    {
        frequencyPlot.Plot.Clear();
        LoadFrequencyPlotView();
        originalLetterFrequencyGrid.Rows.Clear();
        processedLetterFrequencyGrid.Rows.Clear();
        ExtractAndPlotFrequency(textBoxTextToProcess.Text, "Original", originalLetterFrequencyGrid);
        ExtractAndPlotFrequency(textBoxProcessedOutput.Text, "Processed", processedLetterFrequencyGrid);
    }

    private static IEnumerable<LetterFrequency> ExtractLetterFrequencies(string? message)
    {
        if (string.IsNullOrEmpty(message))
            return Enumerable.Empty<LetterFrequency>();

        Dictionary<char, int> letterCount = new(new CaseInvariantLetterComparer());
        foreach (char character in message)
        {
            if (!char.IsLetter(character))
                continue;

            if (letterCount.ContainsKey(character))
                letterCount[character]++;
            else
                letterCount.Add(char.ToLowerInvariant(character), 1);
        }

        int totalCharacters = letterCount.Values.Sum();
        LinkedList<LetterFrequency> letterFrequenciesList = new();
        foreach ((char letter, int count) in letterCount)
        {
            letterFrequenciesList.AddLast(new LetterFrequency(
                Letter: letter,
                Frequency: ((double)count / totalCharacters) * 100));
        }

        return letterFrequenciesList;
    }

    private void ExtractAndPlotFrequency(string? message, string legend, DataGridView dataGrid)
    {
        IEnumerable<LetterFrequency> letterFrequencies = ExtractLetterFrequencies(message)
            .OrderByDescending(letter => letter.Frequency);
        foreach (LetterFrequency letter in letterFrequencies)
        {
            dataGrid.Rows.Add(letter.Letter, letter.Frequency);
        }

        PlotFrequency(letterFrequencies, legend);
    }

    private double[,]? GetGridKey()
    {
        double[,] key = new double[_keyDimension, _keyDimension];
        for (int i = 0; i < _keyDimension; i++)
        {
            for (int j = 0; j < _keyDimension; j++)
            {
                if (int.TryParse(keyGridView[j, i].Value as string, out int value))
                    key[i, j] = value;
                else
                    throw new InvalidOperationException("Key matrix must be filled with integer values.");
            }
        }

        return key;
    }

    private double[,]? GetTextKey()
    {
        string text = textBoxKey.Text;
        if (string.IsNullOrEmpty(text))
            return null;

        if (Math.Sqrt(text.Length) % 1 != 0)
            throw new InvalidOperationException($"Key text's lenght must be perfect square.");

        if (text.Length != _keyDimension * _keyDimension)
            throw new InvalidOperationException($"Key text's lenght must be the square of the key's size.");

        double[,] key = new double[_keyDimension, _keyDimension];
        for (int i = 0; i < _keyDimension; i++)
        {
            int row = i * _keyDimension;
            for (int j = 0; j < _keyDimension; j++)
            {
                if (_lookupTable.TryGetValue(text[row + j], out int index))
                    key[i, j] = index;
                else
                    throw new InvalidOperationException("Key text contains unknown, not present in the alphabet, characters.");
            }
        }

        return key;
    }

    private void Cipher(bool direction)
    {
        if (string.IsNullOrEmpty(textBoxTextToProcess.Text))
            return;

        double[,]? key;
        string? cipheredMessage;
        try
        {
            key = GetTextKey();
            key ??= GetGridKey();
            _hillCipher.Key = key;
            string originalMessage = textBoxTextToProcess.Text;
            cipheredMessage = direction
            ? _hillCipher?.Encrypt(originalMessage)
            : _hillCipher?.Decrypt(originalMessage);
        }
        catch (Exception e) when (e is InvalidOperationException || e is ArgumentException)
        {
            ShowWarningBox(e.Message);
            return;
        }

        textBoxProcessedOutput.Text = cipheredMessage;
        PlotLetterFrequencies();
    }

    private double[,] RandomKey(ICipher<double[,]> cipher, out string textForm)
    {
        Random random = new();
        bool isNotValid = true;
        double[,] key = new double[_keyDimension, _keyDimension];
        while (isNotValid)
        {
            for (int i = 0; i < _keyDimension; i++)
            {
                for (int j = 0; j < _keyDimension; j++)
                    key[i, j] = random.Next(0, _alphabet.Length);
            }
            try
            {
                cipher.Key = key;
            }
            catch (ArgumentException)
            {
                continue;
            }

            isNotValid = false;
        }

        textForm = AsTextKey(key);
        return key;
    }

    private string AsTextKey(double[,] key)
    {
        StringBuilder textKeyBuilder = new();
        for (int i = 0; i < key.GetLength(0); i++)
        {
            int row = i * _keyDimension;
            for (int j = 0; j < key.GetLength(1); j++)
                textKeyBuilder.Append(_alphabet[(int)key[i, j]]);
        }

        return textKeyBuilder.ToString();
    }

    private static void ShowWarningBox(string text)
    {
        MessageBox.Show(text + "\nMake sure of it and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private static void ShowErrorBox(string text)
    {
        MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static void ShowSuccessBox(string text)
    {
        MessageBox.Show(text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void KeyGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
    {
        e.Column.Width = 40;
    }

    private void DisableCipherButtons()
    {
        buttonCipher.Enabled = false;
        buttonDecipher.Enabled = false;
    }

    private void EnableCipherButtons()
    {
        buttonCipher.Enabled = true;
        buttonDecipher.Enabled = true;
    }

    private static string RemoveDublicates(string alphabet)
    {
        HashSet<char> keys = new();
        StringBuilder noDuplicateAlphabet = new();
        foreach (char character in alphabet)
        {
            if (keys.Contains(character))
                continue;

            keys.Add(character);
            noDuplicateAlphabet.Append(character);
        }

        return noDuplicateAlphabet.ToString();
    }

    private Dictionary<char, int> GetLookupTable(string alphabet)
    {
        alphabet = RemoveDublicates(alphabet);
        int index = 0;
        return _lookupTable = alphabet.ToString()
            .ToDictionary(c => c, _ => index++);
    }
}
