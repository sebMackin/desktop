﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Purplecs.Modules.RaceScore.Components;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;


namespace Purplecs.Modules.RaceScore
{
    public partial class Racer : RaceScoreModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var tc = new RacersItemController();
            rptItemList.DataSource = tc.GetItems(ModuleId);
            rptItemList.DataBind();

            try
            {

                ///if the request to the page is the original request
    
                if (!Page.IsPostBack)
                {

                    if (ItemId > 0)
                    {

                        ///Define ItemController tc
                        ///and Define item t via a get request

                        var t = tc.GetItem(ItemId, ModuleId);

                        if (t != null)
                        {

                            ///Set text values of the textboxes
                            ///to the values in the item

                            txtRacername.Text = t.Name;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            ///Define new Item and Item Controller
            var t = new RacersItem();
            var tc = new RacersItemController();

            ///If the item already exists
            if (t.ID > 0)
            {

                ///Set the Values in database to contents of the textboxes and 
                ///set the item using a get request with the item controller
                t = tc.GetItem(ItemId, ModuleId);
                t.Name = txtRacername.Text.Trim();

            }
            else
            {

                ///Create a new instance of Item
                t = new RacersItem()
                {

                    ///get the time created and other values from textboxes
                    ///and put into the database values for the new Item
                    CreatedDate = DateTime.Now,
                    Name = txtRacername.Text.Trim(),
                };
            }

            ///Set the item's module ID
            t.ModuleId = ModuleId;

            ///If the item already exists, then update it
            ///otherwise create a new item with the values
            if (t.ID > 0)
            {

                tc.UpdateItem(t);
                
            }
            else
            {

                tc.CreateItem(t);
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(DotNetNuke.Common.Globals.NavigateURL());
        }
    }
}
