﻿using System;
using System.Diagnostics;
using Xamagon.SeedApp.Common.Logging;

namespace Xamagon.SeedApp.Droid.Providers
{
    public class StackFrameProvider : IStackFrameProvider
    {
        public string GetCallerFullTypeName(int? skipFrames = null)
        {
            Type type = GetCallerFullType(skipFrames);

            return type?.FullName;
        }

        public Type GetCallerFullType(int? skipFrames = null)
        {
            if (skipFrames == null)
            {
                skipFrames = 2;
            }

            var type = new StackFrame(skipFrames.Value).GetMethod()?.DeclaringType;

            return type;
        }
    }
}