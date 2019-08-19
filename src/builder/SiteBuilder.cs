namespace kundex
{
    class SiteBuilder
    {
        private string sourcePath;
        private string destinationPath;
        private string errorMessage;

        public SiteBuilder(string sourcePath, string destinationPath = "") {
            this.sourcePath = sourcePath;
            this.destinationPath = destinationPath;
            this.errorMessage = "";
        }

        public string GetSourcePath() {
            return sourcePath;
        }

        public string GetDestinationPath() {
            return destinationPath;
        }

        public bool Build() {
            return true;
        }

        public string GetError() {
            return "Error: " + errorMessage;
        }
    }
}