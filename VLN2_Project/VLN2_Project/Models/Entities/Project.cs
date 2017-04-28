using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLN2_Project.Models.Entities
{
    public class Project
    {
        public string _title { get; set; }
        int _ownerID { get; set; }
        List<int> _participantIDs { get; set; }
        List<ProjectFile> _files { get; set; }
    }
}