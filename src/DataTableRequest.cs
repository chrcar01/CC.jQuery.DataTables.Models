// NOTE: Most if not all documentation was taken from https://datatables.net/manual/server-side

using System.Collections.Generic;

namespace CC.jQuery.DataTables.Models
{
    /// <summary>
    /// Represents the request from the client that will be sent to the server.
    /// Contains all the properties and data sent by jQuery DataTables request.
    /// </summary>
    public class DataTableRequest
    {
        /// <summary>
        /// Draw counter. This is used by DataTables to ensure that the Ajax returns from server-side processing requests are drawn
        /// in sequence by DataTables (Ajax requests are asynchronous and thus can return out of sequence).
        /// </summary>
        public int Draw
        {
            get; set;
        }

        /// <summary>
        /// Paging first record indicator. This is the start point in the current data set (0 index based - i.e. 0 is the first record).
        /// </summary>
        public int Start
        {
            get;
            set;
        }

        /// <summary>
        /// Number of records that the table can display in the current draw.
        /// It is expected that the number of records returned will be equal to this number,
        /// unless the server has fewer records to return. Note that this can be -1 to indicate that all records
        /// should be returned (although that negates any benefits of server-side processing!)
        /// </summary>
        public int Length
        {
            get;
            set;
        }

        private List<DataTableColumn> _columns;
        /// <summary>
        /// This is used to determine the columns that will be displayed in the table, and where the data
        /// for each column will be obtained. Maps to the following structure:
        /// <list type="bullet">
        ///     <item>columns[i][data] - Column's data source, as defined by columns.data.</item>
        ///     <item>columns[i][name] - Column's name, as defined by columns.name.</item>
        ///     <item>columns[i][searchable] - Flag to indicate if this column is searchable (true) or not (false). This is controlled by columns.searchable.</item>
        ///     <item>columns[i][orderable] - Flag to indicate if this column is orderable (true) or not (false). This is controlled by columns.orderable.</item>
        ///     <item>columns[i][search][value] - Search value to apply to this specific column.</item>
        /// </list>
        /// </summary>
        public List<DataTableColumn> Columns
        {
            get => _columns ?? (_columns = new List<DataTableColumn>());
            set => _columns = value;
        }

        private List<DataTableOrder> _order;
        /// <summary>
        /// <para>
        /// order[i][column] - Column to which ordering should be applied. This is an index reference to the columns array of information that is also submitted to the server.
        /// </para>
        /// <para>
        /// order[i][dir] - Ordering direction for this column. It will be asc or desc to indicate ascending ordering or descending ordering, respectively.
        /// </para>
        /// </summary>
        public List<DataTableOrder> Order
        {
            get => _order ?? (_order = new List<DataTableOrder>());
            set => _order = value;
        }

        /// <summary>
        /// <para>
        /// search[value] - Global search value. To be applied to all columns which have searchable as true.
        /// </para>
        /// <para>
        /// search[regex] - true if the global filter should be treated as a regular expression for advanced searching, false otherwise.
        /// </para>
        /// </summary>
        public DataTableSearch Search
        {
            get; 
            set;
        }
    }
}