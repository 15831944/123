//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_SECTION_SETTINGS : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_SECTION_SETTINGS(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_SECTION_SETTINGS obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_SECTION_SETTINGS() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_SECTION_SETTINGS(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public ushort type {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_type_get(swigCPtr);
      return ret;
    } 
  }

  public ushort geometry {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_geometry_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_geometry_get(swigCPtr);
      return ret;
    } 
  }

  public ushort generation {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_generation_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_generation_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_sources {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_num_sources_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_num_sources_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref sources {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_sources_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_sources_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref destblock {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_destblock_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_destblock_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public string destfile {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_destfile_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_destfile_get(swigCPtr);
      return ret;
    } 
  }

  public byte visibility {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_visibility_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_visibility_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color color {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref layer {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_layer_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_layer_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref ltype {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_ltype_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_ltype_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public double ltype_scale {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_ltype_scale_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_ltype_scale_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref plotstyle {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_plotstyle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_plotstyle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public byte linewt {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_linewt_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_linewt_get(swigCPtr);
      return ret;
    } 
  }

  public ushort face_transparency {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_face_transparency_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_face_transparency_get(swigCPtr);
      return ret;
    } 
  }

  public ushort edge_transparency {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_edge_transparency_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_edge_transparency_get(swigCPtr);
      return ret;
    } 
  }

  public byte hatch_visibility {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_visibility_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_visibility_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref hatch_pattern {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_pattern_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_pattern_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public double hatch_angle {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double hatch_spacing {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_spacing_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_spacing_get(swigCPtr);
      return ret;
    } 
  }

  public double hatch_scale {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_scale_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hatch_scale_get(swigCPtr);
      return ret;
    } 
  }

  public byte hidden_line {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hidden_line_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_hidden_line_get(swigCPtr);
      return ret;
    } 
  }

  public byte division_lines {
    set {
      LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_division_lines_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_SECTION_SETTINGS_division_lines_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_SECTION_SETTINGS() : this(LibreDWGPINVOKE.new_Dwg_Object_SECTION_SETTINGS(), true) {
  }

}
