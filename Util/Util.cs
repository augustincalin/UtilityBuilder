using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities {
    public class Util {
        private string _linkTemplate = "This is a formated link: {0}";
        private Util(string linkTemplate) {
            _linkTemplate = linkTemplate;
        }
        public string GetFormatedGetLink(string param) {
            return string.Format(_linkTemplate, param);
        }

        public class UtilBuilder {
            private string _linkTemplate;
            public UtilBuilder UseGetLink(string linkTemplate) {
                _linkTemplate = linkTemplate;
                return this;
            }
            public static implicit operator Util(UtilBuilder utilBuilder) {
                return new Util(utilBuilder._linkTemplate);
            }
        }
    }
}
