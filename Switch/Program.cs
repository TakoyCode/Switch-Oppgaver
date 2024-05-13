namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var tekst = new TekstForklaring();
            //tekst.SwitchExpressive();

            //var video = new VideoForklaring();
            //video.Run();

            var tasks = new Oppgaver();
            tasks.Run();

        }
    }
}
