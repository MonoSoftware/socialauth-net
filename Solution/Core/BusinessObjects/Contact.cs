﻿/*
===========================================================================
Copyright (c) 2010 BrickRed Technologies Limited

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sub-license, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
===========================================================================

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brickred.SocialAuth.NET.Core.BusinessObjects
{
    /// <summary>
    /// Contains information of logged in user's friends/contacts
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets Firstname and Lastname of a contact
        /// </summary>
        public string Name {  get; internal set; }
        /// <summary>
        /// Gets provider's specific UserID (if provided by provider)
        /// </summary>
        public string ID { get; internal set; }
        /// <summary>
        /// Gets EmailID of a contact (if provided by provider)
        /// </summary>
        public string Email { get; internal set; }
        /// <summary>
        /// Gets Profile URL of a contact (if provided by provider)
        /// </summary>
        public string ProfileURL { get; internal set; }
        /// <summary>
        /// Gets Profile Picture of a contact (if provided by provider)
        /// </summary>
        public string ProfilePictureURL { get; internal set; }
    }
}
