using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap;

namespace Touchless2
{
    class TouchPlane
    {
        private TouchPlaneData data;//Stored data structure for plane configuration;
        private struct Box{
            public Vector TopLeftFront;
            public Vector TopRightFront;
            public Vector BottomLeftFront;
            public Vector BottomRightFront;
            public Vector TopLeftBack;
            public Vector TopRightBack;
            public Vector BottomLeftBack;
            public Vector BottomRightBack;
        }
        private float PlaneXSlope;
        private float PlaneZSlope;
        private float PlaneXSlope2;
        private float PlaneZSlope2;

        private Box bounding;
        public TouchPlane(int ID)
        {
            data = new TouchPlaneData();
            SetDefaults(ID);
        }
        private void SetDefaults(int ID)
        {
            data.ID = ID;
            data.Thickness = 1;
            data.X = 0;
            data.Y = 0;
            data.Z = 0;
            data.Height = 256;
            data.Width = 256;
            data.Xrot = 0;
            data.Yrot = 0;
            data.Zrot = 0;
        }
             
        public TouchPlane(TouchPlaneData myData)
        {
            data = myData;
        }

        //public Vector CheckCollision(Vector Position)
        //{
        //   // if(
        //    return null; 
        //}

    }
}
