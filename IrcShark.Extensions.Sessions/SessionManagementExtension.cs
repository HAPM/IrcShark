﻿// <copyright file="${FILENAME}" company="IrcShark Team">
// Copyright (C) 2009 IrcShark Team
// </copyright>
// <author>$Author$</author>
// <date>$LastChangedDate$</date>
// <summary>Place a summary here.</summary>

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
namespace IrcShark.Extensions.Sessions
{
    using System;
    using System.Collections.Generic;
    using IrcShark.Extensions;

    /// <summary>
    /// The SessionManagementExtension manages configuration and access
    /// sessions to IrcShark. Sessions are bound to users and rights of
    /// this users.
    /// </summary>
    [Extension(Name="Session", Id="IrcShark.Extensions.Sessions.SessionManagementExtension")]
    public class SessionManagementExtension : Extension
    {
        /// <summary>
        /// Saves a list of all active sessions
        /// </summary>
        private List<Session> sessions;
        
        /// <summary>
        /// Initializes a new instance of the SessionManagementExtension class.
        /// </summary>
        public SessionManagementExtension()
        {            
        }
        
        /// <summary>
        /// Starts the SessionManagementExtension.
        /// </summary>
        /// <param name="context">The context, this extension runs in.</param>
        public override void Start(ExtensionContext context)
        {
        }
        
        /// <summary>
        /// Stops the SessionManagementExtension.
        /// </summary>
        public override void Stop()
        {
        }
    }
}