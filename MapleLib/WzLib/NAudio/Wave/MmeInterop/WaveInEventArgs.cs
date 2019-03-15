﻿using System;

namespace MapleLib.WzLib.NAudio.Wave.MmeInterop
{
    /// <summary>
    /// Event Args for WaveInStream event
    /// </summary>
    public class WaveInEventArgs : EventArgs
    {
        private byte[] buffer;
        private int bytes;

        /// <summary>
        /// Creates new WaveInEventArgs
        /// </summary>
        public WaveInEventArgs(byte[] buffer, int bytes)
        {
            this.buffer = buffer;
            this.bytes = bytes;
        }

        /// <summary>
        /// Buffer containing recorded data. Note that it might not be completely
        /// full. <seealso cref="BytesRecorded"/>
        /// </summary>
        public byte[] Buffer => buffer;

        /// <summary>
        /// The number of recorded bytes in Buffer. <seealso cref="Buffer"/>
        /// </summary>
        public int BytesRecorded => bytes;
    }
}