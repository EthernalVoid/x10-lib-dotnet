/*
  This file is part of XTenLib (https://github.com/genielabs/x10-lib-dotnet)
 
  Copyright (2012-2018) G-Labs (https://github.com/genielabs)

  Licensed under the Apache License, Version 2.0 (the "License");
  you may not use this file except in compliance with the License.
  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

  Unless required by applicable law or agreed to in writing, software
  distributed under the License is distributed on an "AS IS" BASIS,
  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  See the License for the specific language governing permissions and
  limitations under the License.
*/

/*
 *     Author: Generoso Martello <gene@homegenie.it>
 *     Project Homepage: https://github.com/genielabs/x10-lib-dotnet
 */

using System;

namespace XTenLib.Drivers
{
    /// <summary>
    /// X10 driver interface.
    /// </summary>
    public interface XTenInterface
    {
        /// <summary>
        /// Open the hardware interface.
        /// </summary>
        bool Open();

        /// <summary>
        /// Close the hardware interface.
        /// </summary>
        void Close();

        /// <summary>
        /// Reads the data.
        /// </summary>
        /// <returns>The data.</returns>
        byte[] ReadData();

        /// <summary>
        /// Writes the data.
        /// </summary>
        /// <returns><c>true</c>, if data was written, <c>false</c> otherwise.</returns>
        /// <param name="bytesToSend">Bytes to send.</param>
        bool WriteData(byte[] bytesToSend);
    }
}

