using System;
using System.Collections.Generic;
using System.Text;

/*3.  Создать класс или структуру (на своё усмотрение), описывающую трехмерный вектор
	Вектор должен быть трехмерным (координаты x, y, z)
	Должны быть методы работы с векторами: сложение и вычитание*/

namespace Lection4
{
    class Vector3D
    {
        private int x;
        private int y;
        private int z;

        public Vector3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }

        public static Vector3D VectorSum(Vector3D firstVector3D, Vector3D secondVector3d)
        {
            return new Vector3D(firstVector3D.X + secondVector3d.X, firstVector3D.Y + secondVector3d.Y, firstVector3D.Z + secondVector3d.Z);
        }

        public static Vector3D VectorDifference(Vector3D firstVector3D, Vector3D secondVector3d)
        {
            return new Vector3D(firstVector3D.X - secondVector3d.X, firstVector3D.Y - secondVector3d.Y, firstVector3D.Z - secondVector3d.Z);
        }

        public override string ToString()
        {
            return String.Format($"x: {X}, y: {Y}, z: {Z}");
        }
    }
}
