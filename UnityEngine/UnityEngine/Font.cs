﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Font
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Script interface for.</para>
  /// </summary>
  public sealed class Font : Object
  {
    /// <summary>
    ///   <para>The material used for the font display.</para>
    /// </summary>
    public Material material { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    public string[] fontNames { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    /// <summary>
    ///   <para>Access an array of all characters contained in the font texture.</para>
    /// </summary>
    public CharacterInfo[] characterInfo { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] set; }

    [Obsolete("Font.textureRebuildCallback has been deprecated. Use Font.textureRebuilt instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Font.FontTextureRebuildCallback textureRebuildCallback
    {
      get
      {
        return this.m_FontTextureRebuildCallback;
      }
      set
      {
        this.m_FontTextureRebuildCallback = value;
      }
    }

    /// <summary>
    ///   <para>Is the font a dynamic font.</para>
    /// </summary>
    public bool dynamic { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The ascent of the font.</para>
    /// </summary>
    public int ascent { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The line height of the font.</para>
    /// </summary>
    public int lineHeight { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The default size of the font.</para>
    /// </summary>
    public int fontSize { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public static event Action<Font> textureRebuilt;

    private event Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

    /// <summary>
    ///   <para>Create a new Font.</para>
    /// </summary>
    /// <param name="name">The name of the created Font object.</param>
    public Font()
    {
      Font.Internal_CreateFont(this, (string) null);
    }

    /// <summary>
    ///   <para>Create a new Font.</para>
    /// </summary>
    /// <param name="name">The name of the created Font object.</param>
    public Font(string name)
    {
      Font.Internal_CreateFont(this, name);
    }

    private Font(string[] names, int size)
    {
      Font.Internal_CreateDynamicFont(this, names, size);
    }

    /// <summary>
    ///   <para>Get names of fonts installed on the machine.</para>
    /// </summary>
    /// <returns>
    ///   <para>An array of the names of all fonts installed on the machine.</para>
    /// </returns>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public static extern string[] GetOSInstalledFontNames();

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_CreateFont([Writable] Font _font, string name);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_CreateDynamicFont([Writable] Font _font, string[] _names, int size);

    /// <summary>
    ///   <para>Creates a Font object which lets you render a font installed on the user machine.</para>
    /// </summary>
    /// <param name="fontname">The name of the OS font to use for this font object.</param>
    /// <param name="size">The default character size of the generated font.</param>
    /// <param name="fontnames">Am array of names of OS fonts to use for this font object. When rendering characters using this font object, the first font which is installed on the machine, which contains the requested character will be used.</param>
    /// <returns>
    ///   <para>The generate Font object.</para>
    /// </returns>
    public static Font CreateDynamicFontFromOSFont(string fontname, int size)
    {
      return new Font(new string[1]{ fontname }, size);
    }

    /// <summary>
    ///   <para>Creates a Font object which lets you render a font installed on the user machine.</para>
    /// </summary>
    /// <param name="fontname">The name of the OS font to use for this font object.</param>
    /// <param name="size">The default character size of the generated font.</param>
    /// <param name="fontnames">Am array of names of OS fonts to use for this font object. When rendering characters using this font object, the first font which is installed on the machine, which contains the requested character will be used.</param>
    /// <returns>
    ///   <para>The generate Font object.</para>
    /// </returns>
    public static Font CreateDynamicFontFromOSFont(string[] fontnames, int size)
    {
      return new Font(fontnames, size);
    }

    /// <summary>
    ///   <para>Does this font have a specific character?</para>
    /// </summary>
    /// <param name="c">The character to check for.</param>
    /// <returns>
    ///   <para>Whether or not the font has the character specified.</para>
    /// </returns>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool HasCharacter(char c);

    /// <summary>
    ///   <para>Request characters to be added to the font texture (dynamic fonts only).</para>
    /// </summary>
    /// <param name="characters">The characters which are needed to be in the font texture.</param>
    /// <param name="size">The size of the requested characters (the default value of zero will use the font's default size).</param>
    /// <param name="style">The style of the requested characters.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void RequestCharactersInTexture(string characters, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style);

    [ExcludeFromDocs]
    public void RequestCharactersInTexture(string characters, int size)
    {
      FontStyle style = FontStyle.Normal;
      this.RequestCharactersInTexture(characters, size, style);
    }

    [ExcludeFromDocs]
    public void RequestCharactersInTexture(string characters)
    {
      FontStyle style = FontStyle.Normal;
      int size = 0;
      this.RequestCharactersInTexture(characters, size, style);
    }

    [RequiredByNativeCode]
    private static void InvokeTextureRebuilt_Internal(Font font)
    {
      Action<Font> textureRebuilt = Font.textureRebuilt;
      if (textureRebuilt != null)
        textureRebuilt(font);
      if (font.m_FontTextureRebuildCallback == null)
        return;
      font.m_FontTextureRebuildCallback();
    }

    /// <summary>
    ///   <para>Returns the maximum number of verts that the text generator may return for a given string.</para>
    /// </summary>
    /// <param name="str">Input string.</param>
    public static int GetMaxVertsForString(string str)
    {
      return str.Length * 4 + 4;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public bool GetCharacterInfo(char ch, out CharacterInfo info, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style);

    [ExcludeFromDocs]
    public bool GetCharacterInfo(char ch, out CharacterInfo info, int size)
    {
      FontStyle style = FontStyle.Normal;
      return this.GetCharacterInfo(ch, out info, size, style);
    }

    [ExcludeFromDocs]
    public bool GetCharacterInfo(char ch, out CharacterInfo info)
    {
      FontStyle style = FontStyle.Normal;
      int size = 0;
      return this.GetCharacterInfo(ch, out info, size, style);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public delegate void FontTextureRebuildCallback();
  }
}
