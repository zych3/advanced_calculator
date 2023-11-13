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

        Matrix m = new Matrix(3, 3);
        Matrix z = new Matrix(3, 3);

        try
        {
            Matrix.DebugPopulate(m, 5);
            Matrix.DebugPopulate(z,3);

            Matrix.DebugPrint(m*z);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }





    }
}