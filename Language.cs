using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Language
    {
        public string langName { get; set; }
        public string langCode { get; set; }
        public string ttsCode { get; set; }
        public string ttsName { get; set; }

        public Language(string langName_, string langCode_)
        {
            this.langName = langName_;
            this.langCode = langCode_;
            this.ttsCode = string.Empty;
            this.ttsName = string.Empty;
        }

        public Language(string langName_, string langCode_, string ttsCode_, string ttsName_)
        {
            this.langName = langName_;
            this.langCode = langCode_;
            this.ttsCode = ttsCode_;
            this.ttsName = ttsName_;
        }
    }
}
