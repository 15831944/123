//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_MLEADERSTYLE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_MLEADERSTYLE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_MLEADERSTYLE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_MLEADERSTYLE() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_MLEADERSTYLE(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public ushort class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_class_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public ushort content_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_content_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_content_type_get(swigCPtr);
      return ret;
    } 
  }

  public ushort mleader_order {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_mleader_order_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_mleader_order_get(swigCPtr);
      return ret;
    } 
  }

  public ushort leader_order {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_leader_order_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_leader_order_get(swigCPtr);
      return ret;
    } 
  }

  public uint max_points {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_max_points_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_max_points_get(swigCPtr);
      return ret;
    } 
  }

  public double first_seg_angle {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_first_seg_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_first_seg_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double second_seg_angle {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_second_seg_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_second_seg_angle_get(swigCPtr);
      return ret;
    } 
  }

  public ushort type {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_type_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color line_color {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_line_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_line_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref line_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_line_type_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_line_type_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public int linewt {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_linewt_set(swigCPtr, value);
    } 
    get {
      int ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_linewt_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_landing {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_has_landing_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_has_landing_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_dogleg {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_has_dogleg_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_has_dogleg_get(swigCPtr);
      return ret;
    } 
  }

  public double landing_gap {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_landing_gap_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_landing_gap_get(swigCPtr);
      return ret;
    } 
  }

  public double landing_dist {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_landing_dist_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_landing_dist_get(swigCPtr);
      return ret;
    } 
  }

  public string description {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_description_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_description_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref arrow_head {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_arrow_head_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_arrow_head_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public double arrow_head_size {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_arrow_head_size_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_arrow_head_size_get(swigCPtr);
      return ret;
    } 
  }

  public string text_default {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_default_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_default_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref text_style {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_style_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_style_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public ushort attach_left {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_left_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_left_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_right {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_right_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_right_get(swigCPtr);
      return ret;
    } 
  }

  public ushort text_angle_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_angle_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_angle_type_get(swigCPtr);
      return ret;
    } 
  }

  public ushort text_align_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_align_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_align_type_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color text_color {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public double text_height {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_height_get(swigCPtr);
      return ret;
    } 
  }

  public byte text_frame {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_frame_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_frame_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_new_format {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_is_new_format_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_is_new_format_get(swigCPtr);
      return ret;
    } 
  }

  public byte text_always_left {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_always_left_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_always_left_get(swigCPtr);
      return ret;
    } 
  }

  public double align_space {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_align_space_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_align_space_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref block {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Color block_color {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD block_scale {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_scale_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_scale_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public byte use_block_scale {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_use_block_scale_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_use_block_scale_get(swigCPtr);
      return ret;
    } 
  }

  public double block_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_rotation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public byte use_block_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_use_block_rotation_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_use_block_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public ushort block_connection {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_connection_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_block_connection_get(swigCPtr);
      return ret;
    } 
  }

  public double scale {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_scale_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_scale_get(swigCPtr);
      return ret;
    } 
  }

  public byte changed {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_changed_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_changed_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_annotative {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_is_annotative_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_is_annotative_get(swigCPtr);
      return ret;
    } 
  }

  public double break_size {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_break_size_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_break_size_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_dir {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_dir_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_dir_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_top {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_top_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_top_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attach_bottom {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_bottom_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_attach_bottom_get(swigCPtr);
      return ret;
    } 
  }

  public byte text_extended {
    set {
      LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_extended_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_MLEADERSTYLE_text_extended_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_MLEADERSTYLE() : this(LibreDWGPINVOKE.new_Dwg_Object_MLEADERSTYLE(), true) {
  }

}
