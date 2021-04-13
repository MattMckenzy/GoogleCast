using GoogleCast.Models.Media;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GoogleCast.Messages.Media
{
    /// <summary>
    /// A request to load and optionally start playback of a new ordered list of media items
    /// </summary>
    [DataContract]
    class QueueInsertMessage : QueueMessage
    {
        /// <summary>
        /// Gets or sets the array of items to insert into the queue. It is sorted (first element will be played first)
        /// </summary>
        /// <remarks>must not be null or empty</remarks>
        [DataMember(Name = "items")]
        public IEnumerable<QueueItem> Items { get; set; }

        /// <summary>
        /// Gets or sets the ID of the item that will be located immediately after the inserted list. 
        /// If the ID is not found or it is not provided, the list will be appended at the end of the existing list.
        /// </summary>
        [DataMember(Name = "insertBefore")]
        public int? InsertBefore { get; set; }
    }
}