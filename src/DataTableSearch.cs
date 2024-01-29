// NOTE: Most if not all documentation was taken from https://datatables.net/manual/server-side
namespace CC.jQuery.DataTables.Models
{
    /// <summary>
    /// <para>
    /// search[value] - Global search value. To be applied to all columns which have searchable as true.
    /// </para>
    /// <para>
    /// search[regex] - true if the global filter should be treated as a regular expression for advanced searching, false otherwise.
    /// </para>
    /// </summary>
    public class DataTableSearch
    {
        /// <summary>
        /// Global search value. To be applied to all columns which have searchable as true.
        /// </summary>
        public string Value
        {
            get; set;
        }

        /// <summary>
        /// true if the global filter should be treated as a regular expression for advanced searching, false otherwise.
        /// Note that normally server-side processing scripts will not perform regular expression searching for performance reasons
        /// on large data sets, but it is technically possible and at the discretion of your script.
        /// </summary>
        public bool Regex
        {
            get; set;
        }
    }
}