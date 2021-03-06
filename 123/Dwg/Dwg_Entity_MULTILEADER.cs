//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Entity_MULTILEADER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Entity_MULTILEADER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Entity_MULTILEADER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Entity_MULTILEADER() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_Entity_MULTILEADER(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Entity parent {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_parent_set(swigCPtr, Dwg_Object_Entity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_parent_get(swigCPtr);
      Dwg_Object_Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Entity(cPtr, false);
      return ret;
    } 
  }

  public ushort class_version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_class_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_MLEADER_AnnotContext ctx {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_ctx_set(swigCPtr, Dwg_MLEADER_AnnotContext.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_ctx_get(swigCPtr);
      Dwg_MLEADER_AnnotContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_MLEADER_AnnotContext(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref mleaderstyle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_mleaderstyle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_mleaderstyle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public uint flags {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_flags_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_flags_get(swigCPtr);
      return ret;
    } 
  }

  public ushort type {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_type_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color color {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref ltype {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_ltype_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_ltype_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public int linewt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_linewt_set(swigCPtr, value);
    } 
    get {
      int ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_linewt_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_landing {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_has_landing_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_has_landing_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_dogleg {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_has_dogleg_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_has_dogleg_get(swigCPtr);
      return ret;
    } 
  }

  public double landing_dist {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_landing_dist_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_landing_dist_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref arrow_handle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_arrow_handle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_arrow_handle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public double arrow_size {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_arrow_size_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_arrow_size_get(swigCPtr);
      return ret;
    } 
  }

  public ushort style_content {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_style_content_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_style_content_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref text_style {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_style_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_style_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public ushort text_left {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_left_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_left_get(swigCPtr);
      return ret;
    } 
  }

  public ushort text_right {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_right_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_right_get(swigCPtr);
      return ret;
    } 
  }

  public ushort text_angletype {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_angletype_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_angletype_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_type {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_type_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color text_color {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public byte has_text_frame {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_has_text_frame_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_has_text_frame_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref block_style {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_style_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_style_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Color block_color {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD block_scale {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_scale_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_scale_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double block_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_rotation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_block_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public ushort style_attachment {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_style_attachment_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_style_attachment_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_annotative {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_is_annotative_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_is_annotative_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_arrowheads {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_num_arrowheads_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_num_arrowheads_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_LEADER_ArrowHead arrowheads {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_arrowheads_set(swigCPtr, Dwg_LEADER_ArrowHead.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_arrowheads_get(swigCPtr);
      Dwg_LEADER_ArrowHead ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_LEADER_ArrowHead(cPtr, false);
      return ret;
    } 
  }

  public uint num_blocklabels {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_num_blocklabels_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_num_blocklabels_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_LEADER_BlockLabel blocklabels {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_blocklabels_set(swigCPtr, Dwg_LEADER_BlockLabel.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_blocklabels_get(swigCPtr);
      Dwg_LEADER_BlockLabel ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_LEADER_BlockLabel(cPtr, false);
      return ret;
    } 
  }

  public byte neg_textdir {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_neg_textdir_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_neg_textdir_get(swigCPtr);
      return ret;
    } 
  }

  public ushort ipe_alignment {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_ipe_alignment_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_ipe_alignment_get(swigCPtr);
      return ret;
    } 
  }

  public ushort justification {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_justification_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_justification_get(swigCPtr);
      return ret;
    } 
  }

  public double scale_factor {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_scale_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_scale_factor_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_dir {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_dir_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_dir_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_top {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_top_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_top_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_bottom {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_bottom_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_attach_bottom_get(swigCPtr);
      return ret;
    } 
  }

  public byte text_extended {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_extended_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MULTILEADER_text_extended_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Entity_MULTILEADER() : this(LibreDWGPINVOKE.new_Dwg_Entity_MULTILEADER(), true) {
  }

}
