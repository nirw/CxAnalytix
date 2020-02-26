﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CxAnalytics.TransformLogic
{
    /// <summary>
    /// Common property keys that can be re-used across record types
    /// </summary>
    internal class PropertyKeys
    {
        public static readonly String KEY_SCANID = "ScanId";
        public static readonly String KEY_SCANPRODUCT = "ScanProduct";
        public static readonly String KEY_SCANTYPE = "ScanType";
        public static readonly String KEY_SCANFINISH = "ScanFinished";
        public static readonly String KEY_SCANSTART = "ScanStart";
        public static readonly String KEY_SCANRISK = "ScanRisk";
        public static readonly String KEY_SCANRISKSEV = "ScanRiskSeverity";
        public static readonly String KEY_PRESET = "Preset";
        public static readonly String KEY_PROJECTID = "ProjectId";
        public static readonly String KEY_PROJECTNAME = "ProjectName";
        public static readonly String KEY_TEAMNAME = "TeamName";
        public static readonly String KEY_SIMILARITYID = "SimilarityId";
    }
}
