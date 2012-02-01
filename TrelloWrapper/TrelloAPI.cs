using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using DotNetOpenAuth;

namespace TrelloWrapper
{
    public class TrelloAPI
    {
        /*
         * Here is the list of classes that need to exist based on the types of API calls that can be made:
         * Board
         * A board is the most basic object. It contains lists
         * 
         * List 
         * A list is a container that holds cards
         * 
         * Card
         * a card can contain any number of members, actions, or checklists
         * 
         * action
         * can be added to a list or card
         * 
         * checklist
         * just an object that can be added to a card
         * 
         * member
         * list of users on a board or in an organization
         * 
         * notification
         * returns a list of notifications based on memmber, board, list, notifcaton id, or card
         * 
         * organization
         * Group of members 
         * 
         * token         
         * returns specific information about a member and thier permissions
         * 
         * Need to create variables to contain API key and the secret so that the user can be authenticated
         */
    }
}
