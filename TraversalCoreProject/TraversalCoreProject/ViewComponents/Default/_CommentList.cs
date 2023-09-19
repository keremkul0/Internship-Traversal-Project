using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TraversalCoreProject.ViewComponents.Default
{
	public class _CommentList : ViewComponent
	{
		private readonly ICommentService commentService;

		public _CommentList(ICommentService commentService)
		{
			this.commentService = commentService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var values = commentService.TGetDestinationById(id);
			return View(values);
		}
	}
}
