//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_PLOTSETTINGS : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_PLOTSETTINGS(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_PLOTSETTINGS obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_PLOTSETTINGS() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_PLOTSETTINGS(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public string page_setup_name {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_page_setup_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_page_setup_name_get(swigCPtr);
      return ret;
    } 
  }

  public string printer_cfg_file {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_printer_cfg_file_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_printer_cfg_file_get(swigCPtr);
      return ret;
    } 
  }

  public string paper_size {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_size_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_size_get(swigCPtr);
      return ret;
    } 
  }

  public string canonical_media_name {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_canonical_media_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_canonical_media_name_get(swigCPtr);
      return ret;
    } 
  }

  public ushort flags {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_flags_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_flags_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref plotview {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plotview_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plotview_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public double left_margin {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_left_margin_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_left_margin_get(swigCPtr);
      return ret;
    } 
  }

  public double bottom_margin {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_bottom_margin_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_bottom_margin_get(swigCPtr);
      return ret;
    } 
  }

  public double right_margin {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_right_margin_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_right_margin_get(swigCPtr);
      return ret;
    } 
  }

  public double top_margin {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_top_margin_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_top_margin_get(swigCPtr);
      return ret;
    } 
  }

  public double paper_width {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_width_get(swigCPtr);
      return ret;
    } 
  }

  public double paper_height {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_height_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2BD plot_origin {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_origin_set(swigCPtr, Dwg_Bitcode_2BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_origin_get(swigCPtr);
      Dwg_Bitcode_2BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2BD plot_window_ll {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_window_ll_set(swigCPtr, Dwg_Bitcode_2BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_window_ll_get(swigCPtr);
      Dwg_Bitcode_2BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2BD plot_window_ur {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_window_ur_set(swigCPtr, Dwg_Bitcode_2BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_window_ur_get(swigCPtr);
      Dwg_Bitcode_2BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2BD(cPtr, false);
      return ret;
    } 
  }

  public double paper_units {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_units_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_units_get(swigCPtr);
      return ret;
    } 
  }

  public double drawing_units {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_drawing_units_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_drawing_units_get(swigCPtr);
      return ret;
    } 
  }

  public ushort plot_paper_unit {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_paper_unit_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_paper_unit_get(swigCPtr);
      return ret;
    } 
  }

  public ushort plot_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_rotation_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public ushort plot_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_plot_type_get(swigCPtr);
      return ret;
    } 
  }

  public string stylesheet {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_stylesheet_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_stylesheet_get(swigCPtr);
      return ret;
    } 
  }

  public ushort std_scale_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_std_scale_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_std_scale_type_get(swigCPtr);
      return ret;
    } 
  }

  public double std_scale_factor {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_std_scale_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_std_scale_factor_get(swigCPtr);
      return ret;
    } 
  }

  public ushort shade_plot_mode {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shade_plot_mode_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shade_plot_mode_get(swigCPtr);
      return ret;
    } 
  }

  public ushort shade_plot_reslevel {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shade_plot_reslevel_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shade_plot_reslevel_get(swigCPtr);
      return ret;
    } 
  }

  public ushort shade_plot_customdpi {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shade_plot_customdpi_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shade_plot_customdpi_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2BD paper_image_origin {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_image_origin_set(swigCPtr, Dwg_Bitcode_2BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_paper_image_origin_get(swigCPtr);
      Dwg_Bitcode_2BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref shadeplot {
    set {
      LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shadeplot_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PLOTSETTINGS_shadeplot_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_PLOTSETTINGS() : this(LibreDWGPINVOKE.new_Dwg_Object_PLOTSETTINGS(), true) {
  }

}
