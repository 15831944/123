//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_SUNSTUDY : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_SUNSTUDY(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_SUNSTUDY obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_SUNSTUDY() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_SUNSTUDY(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public string setup_name {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_setup_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_setup_name_get(swigCPtr);
      return ret;
    } 
  }

  public string desc {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_desc_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_desc_get(swigCPtr);
      return ret;
    } 
  }

  public uint output_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_output_type_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_output_type_get(swigCPtr);
      return ret;
    } 
  }

  public string sheet_set_name {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_sheet_set_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_sheet_set_name_get(swigCPtr);
      return ret;
    } 
  }

  public byte use_subset {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_use_subset_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_use_subset_get(swigCPtr);
      return ret;
    } 
  }

  public string sheet_subset_name {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_sheet_subset_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_sheet_subset_name_get(swigCPtr);
      return ret;
    } 
  }

  public byte select_dates_from_calendar {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_select_dates_from_calendar_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_select_dates_from_calendar_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_dates {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_num_dates_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_num_dates_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_SUNSTUDY_Dates dates {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_dates_set(swigCPtr, Dwg_SUNSTUDY_Dates.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_dates_get(swigCPtr);
      Dwg_SUNSTUDY_Dates ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_SUNSTUDY_Dates(cPtr, false);
      return ret;
    } 
  }

  public byte select_range_of_dates {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_select_range_of_dates_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_select_range_of_dates_get(swigCPtr);
      return ret;
    } 
  }

  public uint start_time {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_start_time_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_start_time_get(swigCPtr);
      return ret;
    } 
  }

  public uint end_time {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_end_time_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_end_time_get(swigCPtr);
      return ret;
    } 
  }

  public uint interval {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_interval_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_interval_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_hours {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_num_hours_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_num_hours_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char hours {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_hours_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_hours_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public uint shade_plot_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_shade_plot_type_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_shade_plot_type_get(swigCPtr);
      return ret;
    } 
  }

  public uint numvports {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_numvports_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_numvports_get(swigCPtr);
      return ret;
    } 
  }

  public uint numrows {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_numrows_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_numrows_get(swigCPtr);
      return ret;
    } 
  }

  public uint numcols {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_numcols_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_numcols_get(swigCPtr);
      return ret;
    } 
  }

  public double spacing {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_spacing_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_spacing_get(swigCPtr);
      return ret;
    } 
  }

  public byte lock_viewports {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_lock_viewports_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_lock_viewports_get(swigCPtr);
      return ret;
    } 
  }

  public byte label_viewports {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_label_viewports_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_label_viewports_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref page_setup_wizard {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_page_setup_wizard_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_page_setup_wizard_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref view {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_view_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_view_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref visualstyle {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_visualstyle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_visualstyle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref text_style {
    set {
      LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_text_style_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SUNSTUDY_text_style_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_SUNSTUDY() : this(LibreDWGPINVOKE.new_Dwg_Object_SUNSTUDY(), true) {
  }

}
