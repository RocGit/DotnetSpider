namespace DotnetSpider.Core.Downloader
{
	/// <summary>
	/// Downloader is the part that downloads web pages and store in Page object.
	/// Downloader has {@link #setThread(int)} method because downloader is always the bottleneck of a crawler,
	/// there are always some mechanisms such as pooling in downloader, and pool size is related to thread numbers.
	/// </summary>
	public interface IDownloader : System.IDisposable
	{
		/// <summary>
		/// Downloads web pages and store in Page object.
		/// </summary>
		/// <param name="request"></param>
		/// <param name="spider"></param>
		/// <returns></returns>
		Page Download(Request request, ISpider spider);

		void AddAfterDownloadCompleteHandler(IAfterDownloadCompleteHandler handler);

		void AddBeforeDownloadHandler(IBeforeDownloadHandler handler);

		IDownloader Clone(ISpider spider);
	}
}
