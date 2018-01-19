using System;

namespace VstsRestApiSamples.ViewModels.Builds
{
    public class GetListOfBuildsResponse
    {
        public class Definitions : BaseViewModel
        {
            public int count { get; set; }
            public Value[] value { get; set; }
        }
        public class Value
        {
            public int id { get; set; }
            public string buildNumber { get; set; }
            public string status { get; set; }
            public string result { get; set; }
            public DateTime queueTime { get; set; }
            public DateTime startTime { get; set; }
            public DateTime finishTime { get; set; }
            public string url { get; set; }
            public Definition definition { get; set; }
            public int buildNumberRevision { get; set; }
            public Project project { get; set; }
            public string uri { get; set; }
            public string sourceBranch { get; set; }
            public string sourceVersion { get; set; }
            public Queue queue { get; set; }
            public string priority { get; set; }
            public string reason { get; set; }
            public Identity requestedFor { get; set; }
            public Identity requestedBy { get; set; }
            public DateTime lastChangedDate { get; set; }
            public Identity lastChangedBy { get; set; }
            public string parameters { get; set; }
            public Plan orchestrationPlan { get; set; }
            public Log logs { get; set; }
            public Repository repository { get; set; }
            public bool keepForever { get; set; }
            public bool retainedByRelease { get; set; }
        }

        public class Identity
        {
            public string id { get; set; }
            public string displayName { get; set; }
            public string uniqueName { get; set; }
            public string url { get; set; }
            public string imageUrl { get; set; }
        }
        public class Definition
        {
            // public string[] drafts { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public string path { get; set; }
            public string type { get; set; }
            public string queueStatus { get; set; }
            public int revision { get; set; }
            public Project project { get; set; }

        }
        public class Project
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public string state { get; set; }
            public int revision { get; set; }
            public string visibility { get; set; }
        }
        public class Queue
        {
            public Pool pool { get; set; }
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Pool
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Plan
        {
            public string planId { get; set; }
        }

        public class Log
        {
            public int id { get; set; }
            public string type { get; set; }
            public string url { get; set; }
        }
        public class Repository
        {
            public string id { get; set; }
            public string type { get; set; }
            //public string clean { get; set; }
            public bool checkoutSubmodules { get; set; }
        }

    }
}
