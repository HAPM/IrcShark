// <copyright file="LogLevel.cs" company="IrcShark Team">
// Copyright (C) 2009 IrcShark Team
// </copyright>
// <author>$Author$</author>
// <date>$LastChangedDate$</date>
// <summary>Contains the ChatManagerExtension class.</summary>

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
namespace IrcShark
{
    /// <summary>
    /// All levels of logging.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// This level defines the message as a debug message.
        /// </summary>
        Debug = -1,
        
        /// <summary>
        /// This level defines the message as an information message.
        /// </summary>
        Information = 0,
        
        /// <summary>
        /// This level defines the message as a warning message.
        /// </summary>
        Warning = 1,
        
        /// <summary>
        /// This level defines the message as an error message.
        /// </summary>
        Error = 2
    }
}
