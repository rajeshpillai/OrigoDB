﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrigoDB.Core
{
    [Serializable]
    public class ChildModelCommandWithResult<M,C,T> :CommandWithResult<M,T> where M : Model where C:Model
    {
        private CommandWithResult<C, T> _command;

        public ChildModelCommandWithResult(CommandWithResult<C,T> command )
        {
            _command = command;
        }
        protected internal override T Execute(M model)
        {
            return _command.Execute(model.ChildFor<C>());
        }
    }
}
