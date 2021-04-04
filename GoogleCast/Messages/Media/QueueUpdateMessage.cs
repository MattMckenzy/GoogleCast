using GoogleCast.Models.Media;
using System.Runtime.Serialization;

namespace GoogleCast.Messages.Media
{
    /// <summary>
    /// Message to update the queue
    /// </summary>
    [DataContract]
    class QueueUpdateMessage : MediaSessionMessage
    {
        /// <summary>
        /// Gets or sets the item id of the currently playing media
        /// </summary>        
        [DataMember(Name = "currentItemId")]
        public int? CurrentItemId { get; set; }

        /// <summary>
        /// Gets or sets the algorithm for selection of the next item when the current item has ended
        /// </summary>
        [IgnoreDataMember]
        public RepeatMode? RepeatMode { get; set; }

        [DataMember(Name = "repeatMode")]
        private string RepeatModeString
        {
            get { return RepeatMode == null ? null : RepeatMode.GetName(); }
            set { RepeatMode = EnumHelper.Parse<RepeatMode>(value); }
        }

        /// <summary>
        /// Gets or sets the shuffle state
        /// </summary>        
        [DataMember(Name = "shuffle")]
        public bool? Shuffle { get; set; }        
    }
}
