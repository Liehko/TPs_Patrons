﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1
{
    public interface Command
    {
        public void Execute();

        public void SetOnCompleted(Action action);
        public void Completed();
    }
}
