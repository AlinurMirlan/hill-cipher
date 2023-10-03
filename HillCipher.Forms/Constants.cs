namespace HillCipher.Forms;

public static class Constants
{
    public static List<LetterFrequency> RussianLetterFrequencies { get; } = new()
    {
        new LetterFrequency('а', 8.01),
        new LetterFrequency('б', 1.59),
        new LetterFrequency('в', 4.54),
        new LetterFrequency('г', 1.70),
        new LetterFrequency('д', 2.98),
        new LetterFrequency('е', 8.45),
        new LetterFrequency('ё', 0.04),
        new LetterFrequency('ж', 0.94),
        new LetterFrequency('з', 1.65),
        new LetterFrequency('и', 7.35),
        new LetterFrequency('й', 1.21),
        new LetterFrequency('к', 3.49),
        new LetterFrequency('л', 4.40),
        new LetterFrequency('м', 3.21),
        new LetterFrequency('н', 6.70),
        new LetterFrequency('о', 10.97),
        new LetterFrequency('п', 2.81),
        new LetterFrequency('р', 4.73),
        new LetterFrequency('с', 5.47),
        new LetterFrequency('т', 6.26),
        new LetterFrequency('у', 2.62),
        new LetterFrequency('ф', 0.26),
        new LetterFrequency('х', 0.97),
        new LetterFrequency('ц', 0.48),
        new LetterFrequency('ч', 1.44),
        new LetterFrequency('ш', 0.73),
        new LetterFrequency('щ', 0.36),
        new LetterFrequency('ъ', 0.04),
        new LetterFrequency('ы', 1.90),
        new LetterFrequency('ь', 1.74),
        new LetterFrequency('э', 0.32),
        new LetterFrequency('ю', 0.64),
        new LetterFrequency('я', 2.01)
    };
}
