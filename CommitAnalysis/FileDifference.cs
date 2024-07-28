using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommitAnalysis
{
    internal class FileDifference
    {
        private List<string> _ReferenceFileLines;
        private List<string> _ComparedFileLines;
        private int _ReferenceFileStartLine;
        private int _ComparedFileStartLine;

        public List<string> ReferenceFileLines {  get { return _ReferenceFileLines; } set { _ReferenceFileLines = value; } }
        public List<string> ComparedFileLines { get { return _ComparedFileLines; } set { _ComparedFileLines = value; } }
        public int ReferenceFileStartLine { get { return _ReferenceFileStartLine; } set { _ReferenceFileStartLine = value; } }
        public int ComparedFileStartLine { get { return _ComparedFileStartLine; } set { _ComparedFileStartLine = value; } }

        public FileDifference()
        {
            _ReferenceFileLines = new List<string>();
            _ComparedFileLines = new List<string>();
            _ReferenceFileStartLine = 0;
            _ComparedFileStartLine = 0;
        }
    }
}
