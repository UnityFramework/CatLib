﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */
 
using CatLib.API.IO;

namespace CatLib.API.INI
{

    public interface IINILoader
    {

        IINIResult Load(IFile file);

        IINIResult Load(string iniData);
        
        IINIResult Load(byte[] iniData);
    
    }

}