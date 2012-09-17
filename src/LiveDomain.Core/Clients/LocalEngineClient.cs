﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveDomain.Core
{
    public class LocalEngineClient<M> : IEngine<M> where M : Model
    {

        public readonly Engine<M> Engine;

        public LocalEngineClient(Engine<M> engine)
        {
            Engine = engine;
        }

        public T Execute<T>(Query<M, T> query)
        {
            return Engine.Execute(query);
        }

        public void Execute(Command<M> command)
        {
            Engine.Execute(command);
        }

        public T Execute<T>(CommandWithResult<M, T> command)
        {
            return Engine.Execute(command);
        }
    }
}
