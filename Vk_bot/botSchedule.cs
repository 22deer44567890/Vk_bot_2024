using System.Collections.Generic;

namespace Vk_bot
{
    internal class botSchedule
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class CanWrite
        {
            public bool allowed { get; set; }
        }

        public class Conversation
        {
            public Peer peer { get; set; }
            public int last_message_id { get; set; }
            public int last_conversation_message_id { get; set; }
            public int in_read { get; set; }
            public int out_read { get; set; }
            public int in_read_cmid { get; set; }
            public int out_read_cmid { get; set; }
            public int version { get; set; }
            public SortId sort_id { get; set; }
            public bool is_marked_unread { get; set; }
            public bool important { get; set; }
            public CanWrite can_write { get; set; }
            public int peer_flags { get; set; }
            public int? unread_count { get; set; }
            public bool? unanswered { get; set; }
        }

        public class Item
        {
            public Conversation conversation { get; set; }
            public LastMessage last_message { get; set; }
        }

        public class LastMessage
        {
            public int date { get; set; }
            public int from_id { get; set; }
            public int id { get; set; }
            public int @out { get; set; }
            public int version { get; set; }
            public int admin_author_id { get; set; }
            public List<object> attachments { get; set; }
            public int conversation_message_id { get; set; }
            public List<object> fwd_messages { get; set; }
            public bool important { get; set; }
            public bool is_hidden { get; set; }
            public int peer_id { get; set; }
            public int random_id { get; set; }
            public string text { get; set; }
        }

        public class Peer
        {
            public int id { get; set; }
            public string type { get; set; }
            public int local_id { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public int unread_count { get; set; }
            public List<Item> items { get; set; }
        }

        public Response response { get; set; }

        public class SortId
        {
            public int major_id { get; set; }
            public int minor_id { get; set; }
        }


    }
}