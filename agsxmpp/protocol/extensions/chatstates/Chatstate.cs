/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * Copyright (c) 2003-2009 by AG-Software 											 *
 * All Rights Reserved.																 *
 * Contact information for AG-Software is available at http://www.ag-software.de	 *
 *																					 *
 * Licence:																			 *
 * The agsXMPP SDK is released under a dual licence									 *
 * agsXMPP can be used under either of two licences									 *
 * 																					 *
 * A commercial licence which is probably the most appropriate for commercial 		 *
 * corporate use and closed source projects. 										 *
 *																					 *
 * The GNU Public License (GPL) is probably most appropriate for inclusion in		 *
 * other open source projects.														 *
 *																					 *
 * See README.html for details.														 *
 *																					 *
 * For general enquiries visit our website at:										 *
 * http://www.ag-software.de														 *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;
using System.Text;

namespace agsXMPP.protocol.extensions.chatstates
{
    /// <summary>
    /// Enumeration of supported Chatstates (JEP-0085)
    /// </summary>
    public enum Chatstate
    {
        /// <summary>
        /// No Chatstate at all
        /// </summary>
        None,
        /// <summary>
        /// Active Chatstate
        /// </summary>
        active,
        /// <summary>
        /// Inactive Chatstate
        /// </summary>
        inactive,
        /// <summary>
        /// Composing Chatstate
        /// </summary>
        composing,
        /// <summary>
        /// Gone Chatstate
        /// </summary>
        gone,
        /// <summary>
        /// Paused Chatstate
        /// </summary>
        paused
    }
}