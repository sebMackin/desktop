/*
' Copyright (c) 2016 Purplecs.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using System.Web.Caching;
using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using DotNetNuke.Entities.Content;

namespace Purplecs.Modules.RaceScore.Components
{
    [TableName("RaceScores_Racers")]
    //setup the primary key for table
    [PrimaryKey("ID", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("RaceScores_Racers", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class RacersItem
    {
        ///<summary>
        /// The ID of the racer
        ///</summary>
        public int ID { get; set; }

        ///<summary>
        /// A string with the name of the racer
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// The date the object was created
        ///</summary>
        public DateTime CreatedDate { get; set; }

        ///<summary>
        /// The module ID of where the object was created
        ///</summary>
        public int ModuleId { get; set; }
    }
}
