﻿using Immense.RemoteControl.Server.Models;

namespace Remotely.Server.Models;

public class RemoteControlSessionEx : RemoteControlSession
{
    public string DeviceId { get; set; } = string.Empty;
    public string OrganizationId { get; set; } = string.Empty;
}
