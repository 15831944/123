//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_GEODATA : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_GEODATA(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_GEODATA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_GEODATA() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_GEODATA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref host_block {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_host_block_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_host_block_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public ushort coord_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_type_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD design_pt {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_design_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_design_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD ref_pt {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_ref_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_ref_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD obs_pt {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_obs_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_obs_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double unit_scale_horiz {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_unit_scale_horiz_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_unit_scale_horiz_get(swigCPtr);
      return ret;
    } 
  }

  public uint units_value_horiz {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_units_value_horiz_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_units_value_horiz_get(swigCPtr);
      return ret;
    } 
  }

  public double unit_scale_vert {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_unit_scale_vert_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_unit_scale_vert_get(swigCPtr);
      return ret;
    } 
  }

  public uint units_value_vert {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_units_value_vert_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_units_value_vert_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD up_dir {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_up_dir_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_up_dir_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD north_dir {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_north_dir_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_north_dir_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public uint scale_est {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_scale_est_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_scale_est_get(swigCPtr);
      return ret;
    } 
  }

  public double user_scale_factor {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_user_scale_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_user_scale_factor_get(swigCPtr);
      return ret;
    } 
  }

  public byte sea_level_corr {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_sea_level_corr_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_sea_level_corr_get(swigCPtr);
      return ret;
    } 
  }

  public double sea_level_elev {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_sea_level_elev_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_sea_level_elev_get(swigCPtr);
      return ret;
    } 
  }

  public double coord_proj_radius {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_proj_radius_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_proj_radius_get(swigCPtr);
      return ret;
    } 
  }

  public string coord_system_def {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_system_def_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_system_def_get(swigCPtr);
      return ret;
    } 
  }

  public string geo_rss_tag {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_geo_rss_tag_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_geo_rss_tag_get(swigCPtr);
      return ret;
    } 
  }

  public string coord_system_datum {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_system_datum_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_system_datum_get(swigCPtr);
      return ret;
    } 
  }

  public string coord_system_wkt {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_system_wkt_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_coord_system_wkt_get(swigCPtr);
      return ret;
    } 
  }

  public string observation_from_tag {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_observation_from_tag_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_observation_from_tag_get(swigCPtr);
      return ret;
    } 
  }

  public string observation_to_tag {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_observation_to_tag_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_observation_to_tag_get(swigCPtr);
      return ret;
    } 
  }

  public string observation_coverage_tag {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_observation_coverage_tag_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_observation_coverage_tag_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_geomesh_pts {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_num_geomesh_pts_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_num_geomesh_pts_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_GEODATA_meshpt geomesh_pts {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_geomesh_pts_set(swigCPtr, Dwg_GEODATA_meshpt.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_geomesh_pts_get(swigCPtr);
      Dwg_GEODATA_meshpt ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_GEODATA_meshpt(cPtr, false);
      return ret;
    } 
  }

  public uint num_geomesh_faces {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_num_geomesh_faces_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_num_geomesh_faces_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_GEODATA_meshface geomesh_faces {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_geomesh_faces_set(swigCPtr, Dwg_GEODATA_meshface.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEODATA_geomesh_faces_get(swigCPtr);
      Dwg_GEODATA_meshface ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_GEODATA_meshface(cPtr, false);
      return ret;
    } 
  }

  public byte has_civil_data {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_has_civil_data_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_has_civil_data_get(swigCPtr);
      return ret;
    } 
  }

  public byte obsolete_false {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_obsolete_false_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_obsolete_false_get(swigCPtr);
      return ret;
    } 
  }

  public double north_dir_angle_deg {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_north_dir_angle_deg_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_north_dir_angle_deg_get(swigCPtr);
      return ret;
    } 
  }

  public double north_dir_angle_rad {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEODATA_north_dir_angle_rad_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEODATA_north_dir_angle_rad_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_GEODATA() : this(LibreDWGPINVOKE.new_Dwg_Object_GEODATA(), true) {
  }

}