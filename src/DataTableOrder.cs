// NOTE: Most if not all documentation was taken from https://datatables.net/manual/server-side
namespace CC.jQuery.DataTables.Models
{
    /// <summary>
    /// <para>
    /// order[i][column] - Column to which ordering should be applied. This is an index reference to the columns array of information that is also submitted to the server.
    /// </para>
    /// <para>
    /// order[i][dir] - Ordering direction for this column. It will be asc or desc to indicate ascending ordering or descending ordering, respectively.
    /// </para>
    /// </summary>
    public class DataTableOrder
    {
        /// <summary>
        /// Column to which ordering should be applied. This is an index reference to the columns array of information that is also submitted to the server.
        /// </summary>
        public int Column
        {
            get; 
            set;
        }

        /// <summary>
        /// Ordering direction for this column. It will be asc or desc to indicate ascending ordering or descending ordering, respectively.
        /// </summary>
        public string Dir
        {
            get; 
            set;
        }
    }
}