﻿using System.IO;
using MapleLib.WzLib.Util;

namespace MapleLib.WzLib.WzProperties
{
    /// <summary>
    /// A wz property which has a value which is a ushort
    /// </summary>
    public class WzShortProperty : WzImageProperty
    {
        #region Fields

        internal string name;
        internal short val;

        internal WzObject parent;
        //internal WzImage imgParent;

        #endregion

        #region Inherited Members

        public override void SetValue(object value)
        {
            val = (short) value;
        }

        public override WzImageProperty DeepClone()
        {
            var clone = new WzShortProperty(name, val);
            return clone;
        }

        public override object WzValue => Value;

        /// <summary>
        /// The parent of the object
        /// </summary>
        public override WzObject Parent
        {
            get => parent;
            internal set => parent = value;
        }

        /*/// <summary>
		/// The image that this property is contained in
		/// </summary>
		public override WzImage ParentImage { get { return imgParent; } internal set { imgParent = value; } }*/
        /// <summary>
        /// The WzPropertyType of the property
        /// </summary>
        public override WzPropertyType PropertyType => WzPropertyType.Short;

        /// <summary>
        /// The name of the property
        /// </summary>
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override void WriteValue(WzBinaryWriter writer)
        {
            writer.Write((byte) 2);
            writer.Write(Value);
        }

        /// <summary>
        /// Disposes the object
        /// </summary>
        public override void Dispose()
        {
            name = null;
        }

        #endregion

        #region Custom Members

        /// <summary>
        /// The value of the property
        /// </summary>
        public short Value
        {
            get => val;
            set => val = value;
        }

        /// <summary>
        /// Creates a blank WzUnsignedShortProperty
        /// </summary>
        public WzShortProperty()
        {
        }

        /// <summary>
        /// Creates a WzUnsignedShortProperty with the specified name
        /// </summary>
        /// <param name="name">The name of the property</param>
        public WzShortProperty(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Creates a WzUnsignedShortProperty with the specified name and value
        /// </summary>
        /// <param name="name">The name of the property</param>
        /// <param name="value">The value of the property</param>
        public WzShortProperty(string name, short value)
        {
            this.name = name;
            val = value;
        }

        #endregion

        #region Cast Values

        public override float GetFloat()
        {
            return val;
        }

        public override double GetDouble()
        {
            return val;
        }

        public override int GetInt()
        {
            return val;
        }

        public override short GetShort()
        {
            return val;
        }

        public override long GetLong()
        {
            return val;
        }

        public override string ToString()
        {
            return val.ToString();
        }

        #endregion
    }
}