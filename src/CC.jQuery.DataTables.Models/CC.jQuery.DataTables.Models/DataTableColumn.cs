// NOTE: Most if not all documentation was taken from https://datatables.net/manual/server-side
// ReSharper disable CommentTypo
namespace CC.jQuery.DataTables.Models
{
    /// <summary>
    /// Represents a column in the DataTables request.
    /// </summary>
    public class DataTableColumn
    {
        /// <summary>
        /// columns[i][data] - Column's data source, as defined by columns.data.
        /// </summary>
        public string Data
        {
            get; set;
        }

        /// <summary>
        /// columns[i][name] - Column's name, as defined by columns.name.
        /// </summary>
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// columns[i][searchable] - Flag to indicate if this column is searchable (true) or not (false). This is controlled by columns.searchable.
        /// </summary>
        public bool Searchable
        {
            get; set;
        }
        
        // ReSharper disable once IdentifierTypo
        /// <summary>
        /// columns[i][orderable] - Flag to indicate if this column is orderable (true) or not (false). This is controlled by columns.orderable.
        /// </summary>
        public bool Orderable
        {
            get; set;
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
            get; set;
        }
    }
}
