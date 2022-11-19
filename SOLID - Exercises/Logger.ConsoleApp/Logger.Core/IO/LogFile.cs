

namespace Logger.Core.IO
{

    using Exceptions;
    using Interfaces;
    using Utilities;
    public class LogFile : ILogFile
    {
        private string? name;
        private string? path;

        public LogFile()
        {

        }
        public string Name
        {
            get
            {
                return this.name!;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvlaidFileName();
                }
                this.name = value;
            }
        }

        public string Path 
        {
            get
            {
                return this.path!;
            }
            private set
            {
                if (!FileValidator.PathExist(value))
                {
                    throw new InvalidPathException();
                }
                this.path = System.IO.Path.GetFullPath(value);
            }
        }

        public int Size => throw new NotImplementedException();

        public string Content => throw new NotImplementedException();

        public void Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
