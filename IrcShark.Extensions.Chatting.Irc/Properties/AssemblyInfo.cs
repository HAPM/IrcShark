﻿// <copyright file="AssemblyInfo.cs" company="IrcShark Team">
// Copyright (C) 2009 IrcShark Team
// </copyright>
// <author>$Author$</author>
// <date>$LastChangedDate$</date>
// <summary>Contains the AssemblyInfo class.</summary>

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

#region Using directives

using System;
using System.Reflection;
using System.Runtime.InteropServices;

using Mono.Addins;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("IrcShark.Extensions.Chatting.Irc")]
[assembly: AssemblyDescription("Adds the irc protocol to the supported protocols of ircshark.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("IrcShark")]
[assembly: AssemblyProduct("IrcShark.Extensions.Chatting.Irc")]
[assembly: AssemblyCopyright("IrcShark Team")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: Addin("IrcProtocol", "0.1")]
[assembly: AddinDependency("IrcShark","0.1")]
[assembly: AddinDependency("ChatManager","0.1")]

// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible(false)]

// The assembly version has following format :
//
// Major.Minor.Build.Revision
//
// You can specify all the values or you can use the default the Revision and 
// Build Numbers by using the '*' as shown below:
[assembly: AssemblyVersion("0.0.*")]