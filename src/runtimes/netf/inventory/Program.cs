﻿namespace inventory
{
  class Program
  {
    static void Main(string[] args)
    {
      NFX.PAL.NetFramework.DotNetFrameworkRuntime.Init();
      NFX.Tools.Inventory.ProgramBody.Main(args);
    }
  }
}