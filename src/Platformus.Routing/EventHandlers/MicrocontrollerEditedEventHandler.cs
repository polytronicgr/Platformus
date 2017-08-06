﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using Platformus.Barebone;
using Platformus.Routing.Data.Entities;
using Platformus.Routing.Events;

namespace Platformus.Routing.EventHandlers
{
  public class MicrocontrollerEditedEventHandler : IMicrocontrollerEditedEventHandler
  {
    public int Priority => 1000;

    public void HandleEvent(IRequestHandler requestHandler, Microcontroller oldMicrocontroller, Microcontroller newMicrocontroller)
    {
      requestHandler.HttpContext.RequestServices.GetService<ICache>().RemoveAll();
    }
  }
}