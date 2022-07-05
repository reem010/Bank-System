namespace Log_in
{
    internal class SQLConnection
    {
        private string v1;
        private object bank;
        private object system;
        private string v2;

        public SQLConnection(string v1, object bank, object system, string v2)
        {
            this.v1 = v1;
            this.bank = bank;
            this.system = system;
            this.v2 = v2;
        }
    }
}