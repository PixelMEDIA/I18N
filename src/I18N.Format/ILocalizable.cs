﻿using System.Xml.Linq;
using System.Resources;
using System.IO;

namespace I18N.Format
{
	interface ILocalizable
	{
		bool Write(ref XDocument doc, string outputPath, string language, ref string FILENAME_PREFIX, ref string ATTRIBUTE_ID, ref XName xname, ref XName xtarget);
		StreamWriter Create(string path, string language, string prefix);
	}
}
