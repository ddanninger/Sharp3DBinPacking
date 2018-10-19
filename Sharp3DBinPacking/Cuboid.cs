using System;

namespace Sharp3DBinPacking
{
    public class Cuboid
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public bool AllowOrientX { get; set; } = true;
        public bool AllowOrientY { get; set; } = true;
        public bool AllowOrientZ { get; set; } = true;
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public decimal Weight { get; set; }
        public object Tag { get; set; }
        internal bool IsPlaced { get; set; }

        public Cuboid() { }
        public Cuboid(decimal width, decimal height, decimal depth) :
            this(width, height, depth, 0, 0, 0, 0, null)
        { }
        public Cuboid(decimal width, decimal height, decimal depth, decimal weight, object tag) :
            this(width, height, depth, 0, 0, 0, weight, tag)
        { }
        public Cuboid(decimal width, decimal height, decimal depth, decimal x, decimal y, decimal z) :
            this(width, height, depth, x, y, z, 0, null)
        { }
        public Cuboid(decimal width, decimal height, decimal depth, decimal x, decimal y, decimal z, decimal weight, object tag)
        {
            Width = width; Height = height; Depth = depth;
            X = x;  Y = y; Z = z;
            Weight = weight;
            Tag = tag;
            AllowOrientX = true; AllowOrientY = true; AllowOrientZ = true;
        }
        public Cuboid(decimal width, decimal height, decimal depth, bool allowX, bool allowY, bool allowZ, decimal x, decimal y, decimal z, decimal weight, object tag)
        {
            Width = width; Height = height; Depth = depth;
            X = x; Y = y; Z = z;
            Weight = weight;
            Tag = tag;
            AllowOrientX = allowX; AllowOrientY = allowY; AllowOrientZ = allowZ;
        }
        public Cuboid(decimal width, decimal height, decimal depth, bool allowX, bool allowY, bool allowZ, decimal weight, object tag)
            : this(width, height, depth, true, true, true, 0, 0, 0, weight, tag)
        {
        }

        public Cuboid CloneWithoutPlaceInformation()
        {
            return new Cuboid(
                Width, Height, Depth
                , AllowOrientX, AllowOrientY, AllowOrientZ
                , 0, 0, 0, Weight, Tag);
        }

        internal bool AllowPlacing(decimal width, decimal height, decimal depth)
        {
            /*
            decimal tol = 1.0M;
            if ((Math.Abs(Width - width) < tol
                && Math.Abs(Height - height) < tol
                && Math.Abs(Depth - depth) < tol))
                return AllowOrientY;
            else if ((Math.Abs(Width - depth) < tol
                && Math.Abs(Height - height) < tol
                && Math.Abs(Depth - width) < tol))
                return AllowOrientZ;
            else if ((Math.Abs(Width - height) < tol
                && Math.Abs(Height - width) < tol
                && Math.Abs(Depth - depth) < tol))
                return AllowOrientZ;
            else if ((Math.Abs(Width - height) < tol
                && Math.Abs(Height - depth) < tol
                && Math.Abs(Depth - width) < tol))
                return AllowOrientY;
            else if ((Math.Abs(Width - depth) < tol
                && Math.Abs(Height - width) < tol
                && Math.Abs(Depth - height) < tol))
                return AllowOrientX;
            else if ((Math.Abs(Width - width) < tol
                && Math.Abs(Height - depth) < tol
                && Math.Abs(Depth - height) < tol))
                return AllowOrientX;
            else
               return false;
               */
            return true;
        }

        public override string ToString()
        {
            return $"Cuboid(X: {X}, Y: {Y}, Z:{Z}, Width: {Width}, Height:{Height}, Depth:{Depth}, Weight: {Weight}, Tag: {Tag})";
        }
    }
}
