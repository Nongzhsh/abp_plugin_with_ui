﻿using System.Collections.Generic;
using Todo.MainProject.Communication.Dto;

namespace Todo.MainProject.Web.Host.Services
{
    public interface IPluginService
    {
        List<PluginObject> GetPluginObjects();
        bool IsNullService();
        string GetPluginPath();
    }
}
