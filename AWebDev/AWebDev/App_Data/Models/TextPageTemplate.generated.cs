//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>TextPageTemplate</summary>
	[PublishedContentModel("textPageTemplate")]
	public partial class TextPageTemplate : PublishedContentModel, IHideFromMenu, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "textPageTemplate";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextPageTemplate(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPageTemplate, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// bodyText: Add content text here.
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// GridText: add two columns text here
		///</summary>
		[ImplementPropertyType("gridText")]
		public Newtonsoft.Json.Linq.JToken GridText
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("gridText"); }
		}

		///<summary>
		/// Image: add image here
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}

		///<summary>
		/// qoute: Add a site quote here.
		///</summary>
		[ImplementPropertyType("qoute")]
		public string Qoute
		{
			get { return this.GetPropertyValue<string>("qoute"); }
		}

		///<summary>
		/// Title: Add title for the main page.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// UmbracoNaviHide: Hide a page from the Menu
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.HideFromMenu.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// SiteDescription: Enter site description here
		///</summary>
		[ImplementPropertyType("siteDescription")]
		public string SiteDescription
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetSiteDescription(this); }
		}

		///<summary>
		/// SiteKeyWords: Enter sites key words for SEO
		///</summary>
		[ImplementPropertyType("siteKeyWords")]
		public string SiteKeyWords
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetSiteKeyWords(this); }
		}

		///<summary>
		/// siteTitle: Enter site title here.
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetSiteTitle(this); }
		}
	}
}