/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2019, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BHG = BH.oM.Geometry;
using System.ComponentModel;
using SCG = SpeckleCoreGeometryClasses;


namespace BH.Engine.Speckle
{
    public static partial class Convert
    {
        [Description("Convert Speckle Line to BHoM Line")]
        public static BHG.Line ToBHoM(this SCG.SpeckleLine speckleLine)
        {
            List<BHG.Point> points = speckleLine.Value.ToPoints();
            return new BHG.Line { Start = points[0], End = points[1] };
        }
    }
}
