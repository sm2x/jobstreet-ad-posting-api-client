﻿using System;
using System.Linq;

namespace JobStreet.AdPostingApi.Client
{
    internal static class EnumExtensions
    {
        public static T GetAttribute<T>(this Enum @enum) where T : Attribute
        {
            return @enum.GetType().GetMember(@enum.ToString())[0]
                .GetCustomAttributes(typeof(T), false)
                .Cast<T>()
                .SingleOrDefault();
        }
    }
}