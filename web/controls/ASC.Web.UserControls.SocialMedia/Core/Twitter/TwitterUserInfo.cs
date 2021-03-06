/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

namespace ASC.SocialMedia.Twitter
{
    public class TwitterUserInfo
    {
        public decimal UserID { get; set; }
        public string ScreenName { get; set; }
        public string UserName { get; set; }
        public string SmallImageUrl { get; set; }
        public string Description { get; set; }
    }
}
