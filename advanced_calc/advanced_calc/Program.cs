namespace advanced_calc;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        ComplexNumber n = new ComplexNumber(5, 5);
        ComplexNumber z = new ComplexNumber(5, 6);

        MessageBox.Show((n == z).ToString());





    }
}