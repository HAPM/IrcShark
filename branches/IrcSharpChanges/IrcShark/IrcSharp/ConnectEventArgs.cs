﻿// <copyright file="ConnectEventArgs.cs" company="IrcShark Team">
// Copyright (C) 2009 IrcShark Team
// </copyright>
// <author>$Author$</author>
// <date>$LastChangedDate$</date>
// <summary>Contains the ConnectEventArgs class.</summary>

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
namespace IrcSharp
{
    using System;

    /// <summary>
    /// The ConnectEventArgs belongs to the <see cref="ConnectEventHandler" /> and the <see cref="IrcClient.OnConnect" /> event.
    /// </summary>
    public class ConnectEventArgs : IrcEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the ConnectEventArgs class.
        /// </summary>
        /// <param name="client">The client the event was fired from.</param>
        public ConnectEventArgs(IrcClient client) : base(client)
        {
        }
    }
}
