﻿using System.Collections.Generic;

namespace TLSharp.Core
{
    public class InlineButton
    {

        public int message_id = -1;
        public string text = string.Empty;

        public List<Choises> list_choises = new List<Choises>();

        public class Choises
        {

            public Choises(string _text, byte[] _data)
            {
                text = _text;
                data = _data;
            }

            public string text = string.Empty;
            public byte[] data = new byte[] { };

        }

    }


}