﻿using System;
using System.Collections.Generic;

namespace ProjectsManagement.API.Resources
{
    public class ProjectForListingResource
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateCreated { get; set; }
        public List<ProjectProgrammerForProjectResource> Programmers { get; set; }
    }
}
